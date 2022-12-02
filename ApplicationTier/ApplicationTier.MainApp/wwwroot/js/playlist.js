
//$(document).ready(function(){

//	$("#jquery_jplayer_2").jPlayer({
//		ready: function () {
//			$(this).jPlayer("setMedia", {
//				title: "Bubble",
//				m4a: "http://www.jplayer.org/audio/m4a/Miaow-07-Bubble.m4a",
//				oga: "http://www.jplayer.org/audio/ogg/Miaow-07-Bubble.ogg"
//			});
//		},
//		play: function() { // To avoid multiple jPlayers playing together.
//			$(this).jPlayer("pauseOthers");
//		},
//		swfPath: "../js",
//		supplied: "m4a, oga",
//		cssSelectorAncestor: "#jp_container_2",
//		wmode: "window",
//		globalVolume: true,
//		useStateClassSkin: true,
//		autoBlur: false,
//		smoothPlayBar: true,
//		keyEnabled: true
//	});

//	$("#jquery_jplayer_1").jPlayer({
//		ready: function () {
//			$(this).jPlayer("setMedia", {
//			});
//		},
//		play: function() { // To avoid multiple jPlayers playing together.
//			$(this).jPlayer("pauseOthers");
//		},
//		swfPath: "../js",
//		//supplied: "m4a, oga",
//		cssSelectorAncestor: "#jp_container_1",
//		wmode: "window",
//		globalVolume: true,
//		useStateClassSkin: true,
//		autoBlur: false,
//		smoothPlayBar: true,
//		keyEnabled: true
//	});

//	new jPlayerPlaylist({
//		jPlayer: "#jquery_jplayer_1",
//		cssSelectorAncestor: "#jp_container_1"
//	}, [
//		{
//			title:"Cro Magnon Man",
//			mp3:"http://www.jplayer.org/audio/mp3/TSP-01-Cro_magnon_man.mp3",
//			//oga:"http://www.jplayer.org/audio/ogg/TSP-01-Cro_magnon_man.ogg"
//		},
//		{
//			title:"Your Face",
//			mp3:"http://www.jplayer.org/audio/mp3/TSP-05-Your_face.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/TSP-05-Your_face.ogg"
//		},
//		{
//			title:"Cyber Sonnet",
//			mp3:"http://www.jplayer.org/audio/mp3/TSP-07-Cybersonnet.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/TSP-07-Cybersonnet.ogg"
//		},
//		{
//			title:"Tempered Song",
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-01-Tempered-song.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-01-Tempered-song.ogg"
//		},
//		{
//			title:"Hidden",
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-02-Hidden.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-02-Hidden.ogg"
//		},
//		{
//			title:"Lentement",
//			free:true,
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-03-Lentement.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-03-Lentement.ogg"
//		},
//		{
//			title:"Lismore",
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-04-Lismore.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-04-Lismore.ogg"
//		}		
//	], {
//		swfPath: "../../dist/jplayer",
//		supplied: "oga, mp3",
//		wmode: "window",
//		useStateClassSkin: true,
//		autoBlur: false,
//		smoothPlayBar: true,
//		keyEnabled: true
//	});

//	new jPlayerPlaylist({
//		jPlayer: "#jquery_jplayer_2",
//		cssSelectorAncestor: "#jp_container_2"
//	}, [
//		{
//			title:"Cro Magnon Man",
//			//mp3:"http://www.jplayer.org/audio/mp3/TSP-01-Cro_magnon_man.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/TSP-01-Cro_magnon_man.ogg"
//		},
//		{
//			title:"Your Face",
//			mp3:"http://www.jplayer.org/audio/mp3/TSP-05-Your_face.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/TSP-05-Your_face.ogg"
//		},
//		{
//			title:"Cyber Sonnet",
//			mp3:"http://www.jplayer.org/audio/mp3/TSP-07-Cybersonnet.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/TSP-07-Cybersonnet.ogg"
//		},
//		{
//			title:"Tempered Song",
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-01-Tempered-song.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-01-Tempered-song.ogg"
//		},
//		{
//			title:"Hidden",
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-02-Hidden.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-02-Hidden.ogg"
//		},
//		{
//			title:"Lentement",
//			free:true,
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-03-Lentement.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-03-Lentement.ogg"
//		},
//		{
//			title:"Lismore",
//			mp3:"http://www.jplayer.org/audio/mp3/Miaow-04-Lismore.mp3",
//			oga:"http://www.jplayer.org/audio/ogg/Miaow-04-Lismore.ogg"
//		}		
//	], {
//		swfPath: "../../dist/jplayer",
//		supplied: "oga, mp3",
//		wmode: "window",
//		useStateClassSkin: true,
//		autoBlur: false,
//		smoothPlayBar: true,
//		keyEnabled: true
//	});
//});