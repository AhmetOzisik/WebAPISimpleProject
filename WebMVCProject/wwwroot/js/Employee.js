function AddEmployee {
    var employee = {
        Id: $("#AddEmployeeId").val(),
        LastName: $("#AddEmployeeLastName").val(),
        FirstName: $("#AddEmployeeFirstName").val(),
        Title: $("#AddEmployeeTitle").val(),
        TitleOfCourtesy: $("#AddEmployeeTitleOfCourtesy").val(),
        BirthDate: $("#AddEmployeeBirthDate").val(),
        HireDate: $("#AddEmployeeHireDate").val(),
        Notes: $("#AddEmployeeNotes").val(),
    };
    $.ajax({
        type: "post",
        url: "/Employee/Add/",
        data: { employee: employee },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Employee basarili bir sekilde eklendi.");
            }
        }
    });
}
function UpdateEmployee() {
    var employee = {
        Id: $("#AddEmployeeId").val(),
        LastName: $("#AddEmployeeLastName").val(),
        FirstName: $("#AddEmployeeFirstName").val(),
        Title: $("#AddEmployeeTitle").val(),
        TitleOfCourtesy: $("#AddEmployeeTitleOfCourtesy").val(),
        BirthDate: $("#AddEmployeeBirthDate").val(),
        HireDate: $("#AddEmployeeHireDate").val(),
        Notes: $("#AddEmployeeNotes").val(),
    };
    $.ajax({
        type: "post",
        url: "/Employee/Update/",
        data: { employee: employee },
        dataType: "json",
        success: function (data) {
            if (data == true) {
                alert("Employee basarili bir sekilde güncellendi.");
            }
        }
    });
}