var myApp= myApp || {};
// to initialize it to empty object 

myApp.triggerAlert =  (forecast) => {

    alert("forecast temp:" + forecast.temperatureC);
}
myApp.showprompt = () => {
    return prompt("what is your name ?");

}