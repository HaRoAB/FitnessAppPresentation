const conditioningButton = document.getElementById("conditioning-button");
const strengthButton = document.getElementById("strength-button");

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

function checkbox(boxId, lableId) {
    const checkbox = document.getElementById(boxId);
    const labelText = document.getElementById(lableId);
    const exerciseBuilder = document.getElementById("exercise-builder");

    if (checkbox.checked) {
        labelText.textContent = "Remove Exercise";
        exerciseBuilder.style.display = "contents";
    } else {
        labelText.textContent = "Add Exercise";
        exerciseBuilder.style.display = "none";
    }
};


document.getElementById("strength-button").addEventListener("click", () => workoutOnClick("strength-builder"));
document.getElementById("conditioning-button").addEventListener("click", () => workoutOnClick("conditioning-builder"));
document.getElementById("btn-check-outlined").addEventListener("change", () => checkbox("btn-check-outlined", "label-text"));