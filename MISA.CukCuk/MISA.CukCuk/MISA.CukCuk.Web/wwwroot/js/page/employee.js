$(document).ready(function () {
    var employeeJs = new EmployeeJs();
    //dialog chi tiết khách hàng
    dialogDetail = $(".m-dialog").dialog({
        autoOpen: false,
        fluid: true,
        //height: 400,
        //width: '700px',
        minWidth: 800,
        resizable: true,
        modal: true,
        position: ({ my: "center", at: "center", of: window }),
    });

    //dialog cảnh báo khi thực hiện các hành động xóa dữ liệu
    dialogWarning = $(".show-pop-up-warning").dialog({
        autoOpen: false,
        fluid: true,
        //height: 400,
        //width: '700px',
        minWidth: 400,
        resizable: true,
        modal: true,
        position: ({ my: "center", at: "center", of: window }),
    });
})

class EmployeeJs extends Base {
    constructor() {
        super();
        //  this.initEvent();
    }
    initEvent() {
        super.initEvent();
        var me = this;

        me.loadComboboxData();

        $(".search-table input[type=search],select[type=search],select[type=search]").on("blur", function () {
            debugger
            //this.setEndPoint();
            var searchText = $(".search-table input[type=search]").val();
            var departmentId = $(".search-table #searchDepartment").val();
            var positionId = $(".search-table #searchPosition").val();

            var query = "";
            var queryString= query.concat("/filter?searchText=", searchText, "&departmentId=", departmentId, "&positionId=", positionId);
            me.endPoint = queryString;
            me.reLoadData();
        })

        //$("body:not(.content-main .content-table)").click(function () {
        //    alert("not table");
        //})
    }
    /**
     * Hàm load lại dữ liệu
     * CreatedBy HNANH(3/12/2020)
     * */
    reLoadData() {
        super.loadData();
    }
    setEndPoint() {
        debugger
    }
    setApiRouter() {
        this.apiRouter = '/api/v1/employees';
    }
    setObjName() {
        this.objName = "Employee";
    }

    loadComboboxData() {
        var me = this;
        //load dữ liệu cho các combobox 
        var selects = $('.search-table select[selectName]');

        //xử lý xóa các option trước để tránh bị trùng khi nhấn button add các lần tiếp theo
        //$('select option').remove();
        selects.empty();

        //hiện thị icon load khi dữ liệu đang được tải
        $(".loading").show();

        $.each(selects, function (index, select) {
            var api = $(this).attr("api");
            var fieldName = $(this).attr("selectName");
            var fieldValue = $(this).attr("selectValue");
            //lấy dữ liệu nhóm khách hàng
            $.ajax({
                url: me.host + api,
                method: "GET",
            }).done(function (res) {
                if (res) {
                    $.each(res, function (index, obj) {
                        var option = $(`<option value=` + obj[fieldName] + `>` + obj[fieldValue] + `</option>`)
                        $(select).append(option);
                    })
                }
                //$(".loading").hide();
                debugger
            }).fail(function (res) {
                $(".loading").hide();
                me.openPopUpMessenger("danger", "Thực hiện lỗi, vui lòng kiểm tra lại");
                debugger
            })
        })
    }
    /**
     * set url lấy dữ liệu
     * CreateBy: HNANH (12/11/2020)
     * */

    

    //initEvent() {
    //    //debugger;
    //    $(".btn-add-labor").click(this.btnAddOnClick);
    //    $(".btn-cancel").click(this.btnCancelOnClick);
    //  //  $(".button-bottom-bar").click(this.btnChangePageOnClick);
    //    $(".button-bottom-bar").focus(this.btnChangePageOnClick);
    //}
    //btnAddOnClick() {
    //    $(".dialog-model").show();
    //    $(".dialog-content").show();
    //}
    //btnCancelOnClick() {
    //    $(".dialog-model").hide();
    //    $(".dialog-content").hide();
    //}
    //btnChangePageOnClick() {
    //    $(this).siblings().removeClass("button-change-page-select");
    //    $(this).addClass("button-change-page-select");
    //}
}