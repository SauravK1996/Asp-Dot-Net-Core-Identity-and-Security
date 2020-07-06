function getProducts() {
    //debugger;
    var urlToGo = "https://localhost:5001/Products/list"
    $.ajax({
        type: "GET",
        dataType: "json",
        url: urlToGo,
        success: function (result) {
            console.info("success called!" + JSON.stringify(result));
            alert(JSON.stringify(result));
            return result;
        },
        error: function () {
            console.error("error calledSomething bad happend! :(");
        }
    });
}