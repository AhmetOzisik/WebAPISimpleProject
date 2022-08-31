function AddCategory() {
    var category = {
        Id: $("#AddCategoryId").val(),
        Description: $("#AddCategoryDescription").val(),
        Name: $("#AddCategoryName").val(),
    };
    $.ajax({
        type: "post",
        url: "/Category/Add/",
        data: { category: category },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Category basarili bir sekilde eklendi.");
            }
        }
    });
}
function UpdateCategory() {
    var category = {
        Id: $("#AddCategoryId").val(),
        Description: $("#AddCategoryDescription").val(),
        Name: $("#AddCategoryName").val(),
    };
    $.ajax({
        type: "post",
        url: "/Category/Update/",
        data: { category: category },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Category basarili bir sekilde güncellendi.");
            }
        }
    });
}