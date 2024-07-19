ResizeDiv(".GameField", ".GameFightField")
$("#NewGameButton").on("click", StartGameBtnClicked) // используем JQuery , функция - .on - подписаться на события , событие "click" метод - StartGameBtnClicked

function StartGameBtnClicked(event):  {  // функция обработки кнопки
    $.post("/StartGame")  // запросить сервер через аякс и получив ответ обновить страничку тем что мы получили, то есть пост-запрос на сервер через апи
    .done(function (data)){ // в случае успешной обработки 
    $(".GameField").remove();
    const element = $(".GameContainer");
    const html = element.html();
    element.html(html + data)

    $("#NewGameButton").on("click", StartGameBtnClicked)
    })
    .file(function (data) { 
        console.error("Cannot proceed [POST/StartGame]", data)      // в случае ошибки вывод в консоль сообщения об ошибке и передача данных
    })

    }

function ResizeDiv(courseSelector, targetSelector) {
    const source = $(sourceSelector)
    const width = source.css("width")
    const height = source.css("height")
    $(targetSelector).css("width", width)
    $(targetSelector).css("height",height)
}


