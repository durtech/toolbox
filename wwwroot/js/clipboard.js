function CopyToClipBoard(id) {
    $("#"+id).addClass('flashBG')
        .delay('1000').queue(function () {
            $("#" + id).removeClass('flashBG').dequeue();
        });
    /* Get the text field */
    var copyText = document.getElementById(id);

    /* Select the text field */
    copyText.innerText;

    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val($("#" + id).text()).select();
    document.execCommand("copy");
    $temp.remove();
    //copyText.setSelectionRange(0, 99999); /* For mobile devices */

    /* Copy the text inside the text field */
    //document.execCommand("copy");

    /* Alert the copied text */
    //alert("Copied the text: " + copyText.value);
}
