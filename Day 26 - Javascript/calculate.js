
function calculate() {
    var num1 = document.getElementById("num1").value;
    var num2 = document.getElementById("num2").value;
    var result = parseInt(num1) + parseInt(num2);
    document.getElementById("result").innerHTML = result;
}

function SimpleIntrest(principal, rate, time) 
{
    return (principal * rate * time) / 100;
}

function greetUser(name)
{
    return "Hello and welcome to JS world : " + name;
}