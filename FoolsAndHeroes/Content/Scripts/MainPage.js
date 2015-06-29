$(document).ready(function () {
    var userName = {
        userName: $('#Username').text().split(" ")[1].split("!")[0]
    };

    $.ajax({
        type: "GET",
        url: "https://localhost:44301/Character/DoIHaveACharacter",
        data: userName,
        dataType: "json",
        success: function (data) {
        },
    });
});