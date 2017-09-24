var getQueryString = function (field, url) {
    var href = url ? url : window.location.href;
    var reg = new RegExp('[?&]' + field + '=([^&#]*)', 'i');
    var string = reg.exec(href);
    return string ? string[1] : null;
};

function displaySearchAddtoLib() {
    var video = document.getElementById('findAddtoLibVideo').value;
    videoId = getQueryString('v', video);
    addPlayer.loadVideoById(videoId);
    addPlayer.stopVideo();
}

function addVideotoLib() {
    var videoURL = document.getElementById('findAddtoLibVideo').value;
    var videoId = getQueryString('v', videoURL);
    var videoName = document.getElementById("videoName").value;
    $.getJSON('/api/addToLib?videoName=' + videoName + "&videoId=" + videoId, function (data) {
        console.log(data);
    })
        .fail(function (err) {
            console.log(err);
        });
    $('#addNewtoModal').modal('toggle');
}