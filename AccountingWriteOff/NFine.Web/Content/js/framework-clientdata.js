var clients = [];
$(function () {
    clients = $.clientsInit();
})
$.clientsInit = function () {
    var dataJson = {
        dataItems: [],
        organize: [],
        role: [],
        duty: [],
        user: [],
        authorizeMenu: [],
        authorizeButton: []
    };
    var init = function () {
        $.ajax({
            url: "/ClientsData/GetClientsDataJson/1",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {
                dataJson.dataItems = data.dataItems;

            }
        });
        $.ajax({
            url: "/ClientsData/GetClientsDataJson/2",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {

                dataJson.organize = data.organize;

            }
        });
        $.ajax({
            url: "/ClientsData/GetClientsDataJson/3",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {

                dataJson.role = data.role;

            }
        });
        $.ajax({
            url: "/ClientsData/GetClientsDataJson/4",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {

                dataJson.duty = data.duty;

            }
        });
        $.ajax({
            url: "/ClientsData/GetClientsDataJson/5",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {

                dataJson.authorizeMenu = eval(data.authorizeMenu);

            }
        });
        $.ajax({
            url: "/ClientsData/GetClientsDataJson/6",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {

                dataJson.authorizeButton = data.authorizeButton;
            }
        });
    }
    init();
    return dataJson;
}