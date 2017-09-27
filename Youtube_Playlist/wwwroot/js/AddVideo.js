var addPlayer;
function onYouTubeIframeAPIReady() {
    addLibPlayer = new YT.Player('addLib-player', {
        height: '200',
        width: '400',
        videoId: 'M7lc1UVf-VE',
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}

function onPlayerReady(event) {
    //event.target.playVideo();
}
var done = false;
function onPlayerStateChange(event) {
    if (event.data == YT.PlayerState.PLAYING && !done) {
        setTimeout(stopVideo, 6000);
        done = true;
    }
}
function stopVideo() {
    addLibPlayer.stopVideo();
}


function displayVideoSearch(elementId, videoPlayer) {
    var video = document.getElementById(elementId).value;
    videoId = getQueryString('v', video);
    addLibPlayer.loadVideoById(videoId);
    addLibPlayer.stopVideo();
}

function addVideotoLibrary(elementId) {
    var videoURL = document.getElementById(elementId).value;
    var videoId = getQueryString('v', videoURL);
    var videoName = document.getElementById("videoName").value;
    $.getJSON('/api/addToLib?videoName=' + videoName + "&videoId=" + videoId, function (data) {
        console.log(data);
    })
        .fail(function (err) {
            console.log(err);
        });
    $('#ModalAddToLibrary').modal('toggle');
}