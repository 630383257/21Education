﻿$(function () {
    var bar;
    $('.fileupload').fileupload({
        dataType: 'json',
        url: $(this).attr("data-url"),
        //add: function (e, data) {
        //    data.context = $('<p/>').text('Uploading...').appendTo(document.body);
        //    data.submit();
        //},
        done: function (e, data) {
            window.parent.$.progressBoxClose();
            console.log(data);
            if (data.result.Code === 0) {
                $("input[name=" + $(this).attr("name").split('.')[0] + "][type=hidden]").val(data.result.FileName)
            }
            window.parent.$.messager.alert('提示', data.result.Message);
        },
        progressall: function (e, data) {
            var progress = parseInt(data.loaded / data.total * 100, 10);
            bar = window.parent.$.progressBox('上传图片', '上传中...');
            bar.progressbar('setValue', progress);
        }
    });
});

//progress
//<div id="progress">
//    <div class="bar" style="width: 0%;"></div>
//</div>
//.bar {
//    height: 18px;
//    background: green;
//}