<?php

class youtube
{

    public $VideoId = "";
    public $Title = "NO TITLE";
    public $ViewCount = -1;
    public $NumDislikes = -1;
    public $NumLikes = -1;

    public function __construct( $link )
    {
        $this->getData( $link );
    }

    private function getData( $link )
    {
        $videoId = $link;
        $matches = array();
        if ( preg_match( "/watch\?v=([^&]+)(&)?/", $link, $matches ) )
        {
            $videoId = $matches[ 1 ];
        }
        $json_output = file_get_contents( "http://gdata.youtube.com/feeds/api/videos/"
             . $videoId . "?v=2&alt=json" );
        $json = json_decode( $json_output, true );

        $this->VideoId = $videoId;
        $this->Title = $json[ 'entry' ][ 'title' ][ '$t' ];
        $this->ViewCount = $json[ 'entry' ][ 'yt$statistics' ][ 'viewCount' ];
        $this->NumDislikes = $json[ 'entry' ][ 'yt$rating' ][ 'numDislikes' ];
        $this->NumLikes = $json[ 'entry' ][ 'yt$rating' ][ 'numLikes' ];
    }

}
