var mainPlayer;

var tag = document.createElement('script');
tag.src = "https://www.youtube.com/player_api";
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);


function onYouTubePlayerAPIReady() {
    mainPlayer = new YT.Player('library-player', {
        height: '360',
        width: '640',
        videoId: getQueryString('v')
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
    mainPlayer.stopVideo();
}

