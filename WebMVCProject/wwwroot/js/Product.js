function AddProduct() {
    var product = {
        Id: $("#AddProductId").val(),
        SupplierId: $("#AddProductSupplierId").val(),
        CategoryId: $("#AddProductCategoryId").val(),
        QuantityPerUnit: $("#AddProductQuantityPerUnit").val(),
        UnitPrice: $("#AddProductUnitPrice").val(),
        UnitsInStock: $("#AddProductUnitsInStock").val(),
        UnitsOnOrder: $("#AddProductUnitsOnOrder").val(),
        ReorderLevel: $("#AddProductReorderLevel").val(),
        Discontinued: document.getElementById('AddProductDiscontinued').checked,
        Name: $("#AddProductName").val(),
    };
    $.ajax({
        type: "post",
        url: "/Product/Add/",
        data: { product: product },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Product basarili bir sekilde eklendi.");
            }
        }
    });
}
function UpdateProduct() {
    var product = {
        Id: $("#AddProductId").val(),
        SupplierId: $("#AddProductSupplierId").val(),
        CategoryId: $("#AddProductCategoryId").val(),
        QuantityPerUnit: $("#AddProductQuantityPerUnit").val(),
        UnitPrice: $("#AddProductUnitPrice").val(),
        UnitsInStock: $("#AddProductUnitsInStock").val(),
        UnitsOnOrder: $("#AddProductUnitsOnOrder").val(),
        ReorderLevel: $("#AddProductReorderLevel").val(),
        Discontinued: document.getElementById('AddProductDiscontinued').checked,
        Name: $("#AddProductName").val(),
    };
    $.ajax({
        type: "post",
        url: "/Product/Update/",
        data: { product: product },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Product basarili bir sekilde güncellendi.");
            }
        }
    });
}