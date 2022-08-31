function AddOrder() {
    var order = {
        Id:$("#AddOrderId").val(),
        CustomerId:$("#AddOrderCustomerId").val(),
        EmployeeId:$("#AddOrderEmployeeId").val(),
        OrderDate:$("#AddOrderOrderDate").val(),
        RequiredDate:$("#AddOrderRequiredDate").val(),
        ShippedDate:$("#AddOrderShippedDate").val(),
        ShipVia:$("#AddOrderShipVia").val(),
        Freight:$("#AddOrderFreight").val(),
        ShipName:$("#AddOrderShipName").val()
    };
    $.ajax({
        type: "post",
        url: "/Order/Add/",
        data: { order: order },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Order basarili bir sekilde eklendi.");
            }
        }
    });
}
function UpdateOrder() {
    var order = {
        id: $("#AddOrderId").val(),
        CustomerId: $("#AddOrderCustomerId").val(),
        EmployeeId: $("#AddOrderEmployeeId").val(),
        OrderDate: $("#AddOrderOrderDate").val(),
        RequiredDate: $("#AddOrderRequiredDate").val(),
        ShippedDate: $("#AddOrderShippedDate").val(),
        ShipVia: $("#AddOrderShipVia").val(),
        Freight: $("#AddOrderFreight").val(),
        ShipName: $("#AddOrderShipName").val()
    };
    $.ajax({
        type: "post",
        url: "/Order/Update/",
        data: {
            order: order
        },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Order basarili bir sekilde güncellendi.");
            }
        }
    });
}