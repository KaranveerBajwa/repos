/**
 * Weather App
 */

// API_KEY for maps api
let API_KEY = "a8e71c9932b20c4ceb0aed183e6a83bb";

/**
 * Retrieve weather data from openweathermap
*/
getWeatherData = (city) => {
  const URL = "https://api.openweathermap.org/data/2.5/weather";
  let weather = fetch(`${URL}?q=${city}&appid=${API_KEY}&units=imperial`)
  return weather.then((response) => {
    console.log(response);
    return response.json();
  }
  ).catch((error)=>
    console.log(error)
   )

}
console.log(getWeatherData('seattle'));
/**
 * Retrieve city input and get the weather data
 */
searchCity = () => {
  const city = document.getElemdocument.getElementById('city-name').innerText = city[0].toUpperCase() + city.substr(1).toLowerCase();
  entById('city-input').value;

  getWeatherData(city).then((response) =>
  {
    showWeatherData(response);
  }).catch((error) =>
    console.log(error)
  )
}

/**
 * Show the weather data in HTML
 */
showWeatherData = (weatherData) => {
  document.getElementById('weather-type').innerText = weatherData.weather[0].main;
  document.getElementById('temp').innerText = weatherData.main.temp;
  document.getElementById('min-temp').innerText= weatherData.main.temp_min;
  document.getElementById('max-temp').innerText = weatherData.main.temp_max;
}

