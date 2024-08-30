
$(document).on("keydown", null,
/**@param eventObject KeyboardEvent*/(eventObject) => {
    switch (eventObject.key) {
        case "ArrowLeft":
            console.log("left")
            break
        case "ArrowRight":
            console.log("right")
            break
        case "ArrowUp":
            console.log("up")
            break
        case "ArrowDown":
            console.log("down")
            break
    }
    console.log(eventObject);
    })

// Функции для движения по стрелкам
function moveLeft() {
    $.post("/api/Direction/Left", function (data) {
        console.log(data); // "Moved Left"
    });
}

function moveUp() {
    $.post("/api/Direction/Up", function (data) {
        console.log(data); // "Moved Up"
    });
}

function moveRight() {
    $.post("/api/Direction/Right", function (data) {
        console.log(data); // "Moved Right"
    });
}

function moveDown() {
    $.post("/api/Direction/Down", function (data) {
        console.log(data); // "Moved Down"
    });
}
});

//$(document).ready(function () {
//    // Функция для обработки нажатий клавиш
//    $(document).keydown(function (event) {
//        switch (event.which) {
//            case 37: // Left arrow key
//                moveLeft();
//                break;
//            case 38: // Up arrow key
//                moveUp();
//                break;
//            case 39: // Right arrow key
//                moveRight();
//                break;
//            case 40: // Down arrow key
//                moveDown();
//                break;
//            default:
//                break;
//        }
//    });

//    // Пустые функции для движения по стрелкам
//    function moveLeft() {
//        console.log("Left arrow key pressed");
//        // Добавьте свою логику здесь
//    }

//    function moveUp() {
//        console.log("Up arrow key pressed");
//        // Добавьте свою логику здесь
//    }

//    function moveRight() {
//        console.log("Right arrow key pressed");
//        // Добавьте свою логику здесь
//    }

//    function moveDown() {
//        console.log("Down arrow key pressed");
//        // Добавьте свою логику здесь
//    }
//});