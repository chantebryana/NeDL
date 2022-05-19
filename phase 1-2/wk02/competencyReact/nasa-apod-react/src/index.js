import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

console.log('Hello World!');

class ImageInfo extends React.Component {
  render() {
    return (
			<div>
				<p>Title: Gravity's Grin</p>
				<p><a href="https://apod.nasa.gov/apod/image/2205/cheshirecat_chandra_complg.jpg">HD Image Link</a></p>
				<br />
				<p><em>Albert Einstein's general theory of relativity, published over 100 years ago, predicted the phenomenon of gravitational lensing. And that's what gives these distant galaxies such a whimsical appearance, seen through the looking glass of X-ray and optical image data from the Chandra and Hubble space telescopes. Nicknamed the Cheshire Cat galaxy group, the group's two large elliptical galaxies are suggestively framed by arcs. The arcs are optical images of distant background galaxies lensed by the foreground group's total distribution of gravitational mass. Of course, that gravitational mass is dominated by dark matter. The two large elliptical \"eye\" galaxies represent the brightest members of their own galaxy groups which are merging. Their relative collisional speed of nearly 1,350 kilometers/second heats gas to millions of degrees producing the X-ray glow shown in purple hues. Curiouser about galaxy group mergers? The Cheshire Cat group grins in the constellation Ursa Major, some 4.6 billion light-years away.</em></p>
			</div>
    );
  }
}

class NasaImage extends React.Component {
  render() {
    return (
      <div>
				<img src="https://apod.nasa.gov/apod/image/2205/cheshirecat_chandra_complg_1024.jpg"></img>
      </div>
    );
  }
}

class DateSelector extends React.Component {
	render () {
		return (
			<div>
				<form name="myForm">
					Select date to display: 
					<input type="date" name="apod" max="2022-05-23"></input>
					<input type="button" value="Search for Image" onClick={() => {console.log("clicky stuffs")}}></input>
				</form>
			</div>
		);
	}
}

class NasaApod extends React.Component {
  render() {
    return (
      <div className="nasa-apod">
        <h1>&#127756; NASA Astronomy Picture of the Day &#127756;</h1>
				<div className="date-selector">
					<DateSelector />
					<br /><br />
				</div>
				<div className="nasa-image">
          <NasaImage />
					<br /><br />
        </div>
        <div className="image-info">
					<ImageInfo />
        </div>
      </div>
    );
  }
}

// ========================================

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(<NasaApod />);
