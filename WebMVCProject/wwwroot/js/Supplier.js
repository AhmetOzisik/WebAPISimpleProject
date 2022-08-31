function AddSupplier() {
    var supplier = {
        Id: $("#AddSupplierId").val(),
        CompanyName: $("#AddSupplierCompanyName").val(),
        ContactName: $("#AddSupplierContactName").val(),
        ContactTitle: $("#AddSupplierContactTitle").val(),
    };
    $.ajax({
        type: "post",
        url: "/Supplier/Add/",
        data: { supplier: supplier },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Supplier basarili bir sekilde eklendi.");
            }
        }
    });
}
function UpdateSupplier() {
    var supplier = {
        Id: $("#AddSupplierId").val(),
        CompanyName: $("#AddSupplierCompanyName").val(),
        ContactName: $("#AddSupplierContactName").val(),
        ContactTitle: $("#AddSupplierContactTitle").val(),
    };
    $.ajax({
        type: "post",
        url: "/Supplier/Update/",
        data: { supplier: supplier },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Supplier basarili bir sekilde güncellendi.");
            }
        }
    });
}