import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

console.log('Hello World!');

class ImageInfo extends React.Component {
  render() {
    return (
      <button className="imageInfo">
        {/* TODO */}
      </button>
    );
  }
}

class NasaImage extends React.Component {
  renderSquare(i) {
    return <ImageInfo />;
  }

  render() {
    const status = 'Next player: X';

    return (
      <div>
        <div className="status">{status}</div>
      </div>
    );
  }
}

class DateSelector extends React.Component {
	render () {
		return (
			<div></div>
		);
	}
}

class NasaApod extends React.Component {
  render() {
    return (
      <div className="nasa-apod">
        <div className="date-selector">
					<DateSelector />
				</div>
				<div className="nasa-image">
          <NasaImage />
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
