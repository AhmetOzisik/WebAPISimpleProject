function GetByIdOrder(id){
    var id = $("#" + id).val();
    location.href = "https://localhost:44363/Order/GetById/" + id;
}
function DeleteOrder(id) {
    var id = $("#" + id).val();
    $.ajax({
        type: "post",
        url: "/Order/Delete/" + id,
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Id si " + id + " olan Order Basarili Bir Sekilde Silindi");
            }
        }

    });
}
function GetByIdProduct(id) {
    var id = $("#" + id).val();
    location.href = "https://localhost:44363/Product/GetById/" + id;
}
function DeleteProduct(id) {
    var id = $("#" + id).val();
    $.ajax({
        type: "post",
        url: "/Product/Delete/" + id,
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Id si " + id + " olan Product Basarili Bir Sekilde Silindi");
            }
        }

    });
}
function GetByIdCategory(id) {
    var id = $("#" + id).val();
    location.href = "https://localhost:44363/Category/GetById/" + id;
}
function DeleteCategory(id) {
    var id = $("#" + id).val();
    $.ajax({
        type: "post",
        url: "/Category/Delete/" + id,
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Id si " + id + " olan Category Basarili Bir Sekilde Silindi");
            }
        }

    });
}
function GetByIdEmployee(id) {
    var id = $("#" + id).val();
    location.href = "https://localhost:44363/Employee/GetById/" + id;
}
function DeleteEmployee(id) {
    var id = $("#" + id).val();
    $.ajax({
        type: "post",
        url: "/Employee/Delete/" + id,
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Id si "+id+" olan Employee Basarili Bir Sekilde Silindi");
            }
        }

    });
}
function GetByIdSupplier(id) {
    var id = $("#" + id).val();
    location.href = "https://localhost:44363/Supplier/GetById/" + id;
}
function DeleteSupplier(id) {
    var id = $("#" + id).val();
    $.ajax({
        type: "post",
        url: "/Supplier/Delete/" + id,
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Id si " + id + " olan Supplier Basarili Bir Sekilde Silindi");
            }
        }

    });
}
function GetByIdShipper(id) {
    var id = $("#" + id).val();
    location.href = "https://localhost:44363/Shipper/GetById/" + id;
}
function DeleteShipper(id) {
    var id = $("#" + id).val();
    $.ajax({
        type: "post",
        url: "/Shipper/Delete/" + id,
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Id si " + id + " olan Shipper Basarili Bir Sekilde Silindi");
            }
        }

    });
}