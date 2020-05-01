let userPromise = fetch("https://randomuser.me/api/dddd/");
console.log(userPromise);
userPromise.then((response) =>{ 
    return response.json();
}).then((resData) =>
console.log(resData.results[0].name.first)
).catch((error) =>(
 
    console.log(error)
))