const conditioningButton = document.getElementById("conditioning-button");
const strengthButton = document.getElementById("strength-button");
const intervalsButton = document.getElementById("intervals-button");

const workoutCarousel = document.getElementById("workout-carousel");

let id = "";

// Add a click event handler to the button
function workoutOnClick(id) {
    const workoutBuilder = document.getElementById(id);
    const workoutBuilderStyle = window.getComputedStyle(workoutBuilder);
    console.log(workoutBuilderStyle.display);
    if (workoutBuilderStyle.display === "none") {
        workoutBuilder.style.display = "contents";
        workoutCarousel.style.display = "none";
    }
}


document.getElementById("strength-button").addEventListener("click", () => workoutOnClick("strength-builder"));
document.getElementById("conditioning-button").addEventListener("click", () => workoutOnClick("conditioning-builder"));
document.getElementById("intervals-button").addEventListener("click", () => workoutOnClick("intervals-builder"));