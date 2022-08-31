function AddShipper() {
    var shipper = {
        Id: $("#AddShipperId").val(),
        CompanyName: $("#AddShipperCompanyName").val(),
        Phone: $("#AddShipperPhone").val(),
    };
    $.ajax({
        type: "post",
        url: "/Shipper/Add/",
        data: { shipper: shipper },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Shipper basarili bir sekilde eklendi.");
            }
        }
    });
}
function UpdateShipper() {
    var shipper = {
        Id: $("#AddShipperId").val(),
        CompanyName: $("#AddShipperCompanyName").val(),
        Phone: $("#AddShipperPhone").val(),
    };
    $.ajax({
        type: "post",
        url: "/Shipper/Update/",
        data: { shipper: shipper },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Shipper basarili bir sekilde güncellendi.");
            }
        }
    });
}