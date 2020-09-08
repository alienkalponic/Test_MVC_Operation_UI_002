$(document).ready(function () {

    var _BaseURL = window.location.origin;
    //var action_name = !$.isNull($.getactionname()) ? $.getactionname().toLowerCase() : "";
    //var contollername = !$.isNull($.getcontrollername()) ? $.getcontrollername().toLowerCase() : "";
    //if (action_name === "person_registration") {

    $(document).on("click", "#btn_submit", function () {
        //var formdata = $.formdata("#add_student_details_form");
        var nm = $("#txt_nm").val();
        var addr = $("#txt_addr").val();
        var email = $("#txt_email").val();
        var txt_ph = $("#txt_ph").val();
        var ct = $("#ddl_ct option:selected").val();
        var gen = $('input[type="radio"][name="gender"]:checked').val();
        var formData = new FormData();
        formData.append("NAME", nm);
        formData.append("ADDRESS", addr);
        formData.append("EMAIL_ID", email);
        formData.append("PHONE_NO", txt_ph);
        formData.append("CITY", ct);
        formData.append("GENDER", gen);
            $.ajax({
                type: "POST",
                url: _BaseURL + "/Registration_Modeluse/registration-insert-data",
                data: formData,
                dataType: "json",
                processData: false,
                contentType: false,
                success: function (result) {
                        $.alert({
                            title: 'Success!',
                            content: result.Message,
                            type: 'green',
                            buttons: {
                                ok: function () {
                                    tableDataBind();
                                }
                            }
                        });
                },
                error: function () {

                }
            });
     });
    tableDataBind();
    $("#table_data").hide();
    function tableDataBind() {
        $("#table_data").show();
        $.ajax({
            type: "GET",
            url: "/Registration_Modeluse/table-data-show",
            dataType: "json",
            contentType: "application/json;charset=uft-8",
            async: false,
            cache: false,
            success: function (data) {
                $("#Get_aaplication_response").Gridview(data.dataTable, {

                    autocolumn: false,
                    column: [

                        { name: "NAME", dbcol: "NAME" },
                        { name: "ADDRESS", dbcol: "ADDRESS" },
                        { name: "EMAIL ID", dbcol: "EMAIL_ID" },
                        { name: "PHONE NO", dbcol: "PHONE_NO" },
                        { name: "CITY", dbcol: "CITY" },
                        { name: "GENDER", dbcol: "GENDER" }
                    ],
                });
            },
            error: function () {
            }
        });
    }
    $(document).on('click', "#btn_search", function () {
        var mail = $("#mailid").val();
        $.ajax({
            type: "GET",
            url: "/Registration_Modeluse/table-data-search",
            data: { email_id: mail },
            dataType: "json",
            contentType: "application/json;charset=uft-8",
            async: false,
            cache: false,
            success: function (data) {
                $("#Get_aaplication_search").Gridview(data.dataTable, {

                    autocolumn: false,
                    column: [

                        { name: "NAME", dbcol: "NAME" },
                        { name: "ADDRESS", dbcol: "ADDRESS" },
                        { name: "EMAIL ID", dbcol: "EMAIL_ID" },
                        { name: "PHONE NO", dbcol: "PHONE_NO" },
                        { name: "CITY", dbcol: "CITY" },
                        { name: "GENDER", dbcol: "GENDER" }
                    ],
                });
            },
            error: function () {
            }
        });
    });
});