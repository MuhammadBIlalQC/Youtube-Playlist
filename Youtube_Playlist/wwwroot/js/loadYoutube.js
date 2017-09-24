var mainPlayer, searchPlayer, addPlayer;
function onYouTubeIframeAPIReady() {
    mainPlayer = new YT.Player('main-player', {
        height: '390',
        width: '640',
        videoId: getQueryString('v'),
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
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
    mainPlayer.stopVideo();
}


