window.BlazorExtensions = {
    SetupMineSweeper: function (dotnet) {
        var eles = document.getElementsByClassName("box");
        Array.from(eles).forEach((el) => {
            el.addEventListener("contextmenu", function (event) {
                var isRightMB;

                if (event.which == 3)  // Gecko (Firefox), WebKit (Safari/Chrome) & Opera
                    isRightMB = true;
                else if (event.button == 2)  // IE, Opera 
                    isRightMB = true;
                if (isRightMB)
                    dotnet.invokeMethodAsync('BoxRightClicked', el.id)
                else
                    dotnet.invokeMethodAsync('BoxLeftClicked', el.id);
                event.preventDefault();
            });
            el.addEventListener("click", function (event) {
                dotnet.invokeMethodAsync('BoxLeftClicked', el.id);
                event.preventDefault();
            });
        });
    }
}