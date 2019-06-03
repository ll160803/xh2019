<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_MDM_D_DEPT>" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <script src="<%: Url.Content("~/Scripts/jquery2.0.min.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/bootstrap/css/bootstrap.min.css")%>" rel="stylesheet"
        type="text/css" />
    <script src="<%: Url.Content("~/Res/bootstrap/js/bootstrap.js")%>" type="text/javascript"></script>
    <title>供应商注册页面</title>
    <script language="javascript" type="text/javascript">
        function ajaxFrom(form, url) {
            alert(url);
            $.ajax({
                url: url,
                type: "Post",
                data: $(form).serialize(),
                dataType: "json",
                success: function (data) {
                    var msg = data.substring(0, 1);
                    if (msg == 'F') {
                        alert(data);
                        return false;
                    }
                    if (msg == 'S') {
                        alert("保存成功");
                        window.history.go(-1);
                    } else {
                        alert(data); ;
                    }
                }
            });

        }
        $(function () {

            $("form").submit(function (form) {

                ajaxFrom(this, this.action);

                return false;
            });
        });
    </script>
</head>
<body>
    <div class="container">
        <form class="form-horizontal">
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                供应商名称</label>
            <div class="col-md-4">
                <input name="NAME" type="text" id="NAME" placeholder="必填项，单位全称" class="form-control"
                    value="<%:Model.NAME %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                联系人</label>
            <div class="col-md-4">
                <input name="LINK_PERSON" id="LINK_PERSON" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.LINK_PERSON %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                办公电话</label>
            <div class="col-md-4">
                <input name="PHONE" id="PHONE" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.PHONE %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                电子邮箱</label>
            <div class="col-md-4">
                <input name="EMAIL" id="EMAIL" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.EMAIL %>" required pattern="^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$"
                    title="邮箱正确格式：xxx@xxx.xxx">
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                地址</label>
            <div class="col-md-4">
                <input name="ADDRESS" id="ADDRESS" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.ADDRESS %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                工商营业执照</label>
            <div class="col-md-4">
                <input name="BANK_NAME" id="BANK_NAME" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.BANK_NAME %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                组织机构代码</label>
            <div class="col-md-4">
               <input name="BANK_ADDRESS" id="BANK_ADDRESS" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.BANK_ADDRESS %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                税务登记证</label>
            <div class="col-md-4">
                <input name="BANK_NUMBER" id="BANK_NUMBER" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.BANK_NUMBER %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
                药品经营许可证</label>
            <div class="col-md-4">
                  <input name="SERVICES" id="SERVICES" type="text" placeholder="必填项" class="form-control"
                    value="<%:Model.SERVICES %>" required>
            </div>
        </div>
        <div class="form-group form-group-sm">
            <label class="col-md-3 control-label">
            </label>
            <div class="col-md-4">
                <button class="btn btn-primary" type="submit" id="ok">
                    保存</button>
                <button class="btn btn-primary" type="button" id="Button1" onclick="window.history.go(-1);">
                    返回</button>
            </div>
        </div>
        </form>
    </div>
</body>
</html>
