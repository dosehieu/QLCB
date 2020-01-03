var isShift = false;
debugger
var seperator = "/";
debugger
//set crlt+C, Crlt +v
var ctrlDown = false,
    ctrlKey = 17,
    cmdKey = 91,
    vKey = 86,
    cKey = 67;
debugger
$(document).keydown(function (e) {
    debugger
    if (e.keyCode == ctrlKey || e.keyCode == cmdKey) ctrlDown = true;
}).keyup(function (e) {
    debugger
    if (e.keyCode == ctrlKey || e.keyCode == cmdKey) ctrlDown = false;
});
//end
debugger
//Reference the Table.
//var tblForm = document.getElementById("tblForm");
//Reference all INPUT elements in the Table.
var inputs = document.getElementsByTagName("input");
//Loop through all INPUT elements.
for (var i = 0; i < inputs.length; i++) {
    debugger
    //Check whether the INPUT element is TextBox.
    if (inputs[i].type === "text") {
        debugger
        //Check whether Date Format Validation is required.
        if (inputs[i].className.indexOf("month-year") !== -1) {
            debugger
            //Set Max Length.
            inputs[i].setAttribute("maxlength", 7); debugger
            //Only allow Numeric Keys.
            inputs[i].onkeydown = function (e) {
                debugger
                return IsNumeric2(this, e.keyCode);
            };
            //Validate Date as User types.
            inputs[i].onkeyup = function (e) {
                debugger
                ValidateDateFormat2(this, e.keyCode);
            };
        }
    }
}

function IsNumeric2(input, keyCode) {
    if (keyCode === 16) {
        isShift = true;
    }
    //Allow only Numeric Keys.
    if (((keyCode >= 48 && keyCode <= 57) || keyCode === 8 || keyCode <= 37 || keyCode <= 39 || (keyCode >= 96 && keyCode <= 105) || (ctrlDown && (e.keyCode == cKey)) || ctrlDown && (e.keyCode == vKey)) && isShift === false) {
        if ((input.value.length === 2) && keyCode !== 8  ) {
            input.value += seperator;
        }

        return true;
    }
    else {
        return false;
    }
}

function ValidateDateFormat2(input, keyCode) {
    var dateString = input.value;
    if (keyCode === 16) {
        isShift = false;
    }
    var regex = /((0[1-9]|1[0-2])\/((19|20)\d\d))$/;
    //Check whether valid dd/MM/yyyy Date Format.
    if (regex.test(dateString) || dateString.length === 0) {
        ShowHideError(input, "none");
    } else {
        ShowHideError(input, "block");
    }
}

function ShowHideError(textbox, display) {
    //var row = textbox.parentNode.parentNode;
    //var errorMsg = row.getElementsByTagName("span")[0];
    //if (errorMsg !== null) {
    //    errorMsg.style.display = display;
    //}
}