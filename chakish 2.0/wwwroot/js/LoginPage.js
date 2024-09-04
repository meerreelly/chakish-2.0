function ToReg(){
    document.getElementById("LoginBody").style.display = "none";
    document.getElementById("RegBody").style.display = "block";
    document.getElementById("RegInfo").style.display = "none";
    document.getElementById("LogInfo").style.display = "block";
    document.getElementById("errorContainerReg").style.display = "none";
    document.getElementById("errorContainer").style.display = "none";
}

function ToLogin(){
    document.getElementById("LoginBody").style.display = "block";
    document.getElementById("RegBody").style.display = "none";
    document.getElementById("RegInfo").style.display = "block";
    document.getElementById("LogInfo").style.display = "none";
    document.getElementById("errorContainerReg").style.display = "none";
    document.getElementById("errorContainer").style.display = "none";
}

// wwwroot/js/site.js
function WrongPassOrUsername() {
    document.getElementById("errorContainer").style.display = "block";
    document.getElementById("errorMessage").innerText = "Wrong password or username";
}
function UserExist(){
    document.getElementById("errorContainerReg").style.display = "block";
    document.getElementById("errorMessageReg").innerText = "Username is already in use";
}
function GetToken(){
    const token = localStorage.getItem("authToken");
    return token !== null ? token : "";
}
function AccountCreated(){
    document.getElementById("errorContainerReg").style.display = "block";
    document.getElementById("errorMessageReg").innerText = "Account created successfully";
}
