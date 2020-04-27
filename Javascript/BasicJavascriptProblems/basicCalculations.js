function add(num1, num2)
{
    return num1 + num2;
}

console.log(add(2,5));
console.log(add(10,15));

function convertMinutesToSeconds(minutes)
{
    return minutes * 60;
}
console.log(convertMinutesToSeconds(10));
console.log(convertMinutesToSeconds(60));

function convertAgeInYearsToSeconds(age)
{
    return age * 365 * 24 * 60 * 60;    
}
console.log(convertAgeInYearsToSeconds(9));

function badOrGoodMovie(ranking)
{
    if(ranking < 7)
        return "Bad";
    else
     return "Good";
}

console.log(badOrGoodMovie(5));
console.log(badOrGoodMovie(8));

function isStringEmpty(someString)
{
    let isEmpty;
    if(someString == null || someString.length < 1)
        isEmpty = true;
    else
        isEmpty = false;
    return isEmpty;
    }

 
console.log(isStringEmpty(""));
console.log(isStringEmpty(null));
console.log(isStringEmpty("Hello"));

function findMin(nums)
{
    if(nums == null || nums.length ==0)
        return null;
    let min = nums[0] ;
    for(var i=1; i < nums.length; i++)
    {
        if( nums[i] < min)
        min = nums[i];
    }
    return min;
}

function findMax(nums)
{
    let max = nums[0];
    for(let i = 1; i < nums.length;i++)
    {
        if(nums[i] > max)
        {
            max = nums[i];
        }
    }
    return max;
}

let nums = [12,3,4,5 ,6,-8];
console.log(findMin(nums));
console.log(findMax(nums));