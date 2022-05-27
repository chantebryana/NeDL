import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

class ImageInfo extends React.Component {
  render() {
    return (
			<div>
				<p>Title: {this.props.title}</p>
				<p><a href={this.props.hdurl}>HD Image Link</a></p>
				<br />
				<p><em>{this.props.explanation}</em></p>
			</div>
    );
  }
}

class NasaImage extends React.Component {
  render() {
    return (
      <div>
				<img src={this.props.url}></img>
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
					<input type="date" name="apod" max="2022-05-27" onChange={this.props.onDateChange}></input>
					<input type="button" value="Search for Image" onClick={() => {console.log(this.props.onButtonClick(this.props.date))}}></input>
				</form>
			</div>
		);
	}
}

class NasaApod extends React.Component {
	//set state data
	state = {
		date: "", 
		apiResponse: ""
	}
	
	//event handler for date change
	handleDateChange = (event) => {
		//change date key of state with user's input
		this.setState({date: event.target.value});
	}

	//manage API calls
	getApiData = async(dateString) => {
		//01) declare variables
		//API URL; includes unique api key (allows something like 1000 hits per day)
		let apiString = "https://api.nasa.gov/planetary/apod?api_key=d2VP3j0H9CX6rTtCLLpEHRKjHfjXf4SEsh3JaCPo";

		//02) make API call (depending on date selected)
		apiString = apiString + "&date=" + dateString;
		console.log(apiString);

		//make API call and parse json
		let response = await fetch(apiString);
		let jsonData = await response.json();
		
		//store in state
		this.setState({apiResponse: jsonData});
	}

  render() {
    return (
      <div className="nasa-apod">
        <h1>&#127756; NASA Astronomy Picture of the Day &#127756;</h1>
				<div className="date-selector">
					<DateSelector onDateChange = {this.handleDateChange} date = {this.state.date} onButtonClick = {this.getApiData}/>
					<br /><br />
				</div>
				<div className="nasa-image">
          <NasaImage url={this.state.apiResponse.url}/>
					<br /><br />
        </div>
        <div className="image-info">
					<ImageInfo title={this.state.apiResponse.title} hdurl={this.state.apiResponse.hdurl} explanation={this.state.apiResponse.explanation}/>
        </div>
      </div>
    );
  }
}

// ========================================

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(<NasaApod />);
