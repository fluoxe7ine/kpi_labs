const formatDuration = (seconds) => {
let result = [];
let mainStr = '';
if (seconds == 0) return 'now';
//years
let yearsCount = Math.floor(seconds / 31536000);
seconds -= yearsCount*31536000;
if (yearsCount == 1) result.push(`1 year`)
else if (yearsCount > 1) result.push(`${yearsCount} years`);
console.log(yearsCount);
//days
let daysCount = Math.floor(seconds / 86400);
seconds -= daysCount*86400;
if (daysCount == 1) result.push(`1 day`)
else if (daysCount > 1) result.push(`${daysCount} days`);
console.log(daysCount);
//hours
let hoursCount = Math.floor(seconds / 3600);
seconds -= hoursCount*3600;
if (hoursCount == 1) result.push(`1 hour`)
else if (hoursCount > 1) result.push(`${hoursCount} hours`);
console.log(hoursCount);
//minutes
let minutesCount = Math.floor(seconds / 60);
seconds -= minutesCount*60;
if (minutesCount == 1) result.push(`1 minute`)
else if (minutesCount > 1) result.push(`${minutesCount} minutes`);
console.log(minutesCount);
//seconds
let secondsCount = seconds;
if (secondsCount == 1) result.push(`1 second`)
else if (secondsCount > 1) result.push(`${secondsCount} seconds`);
console.log(secondsCount);
console.log(result);
switch (result.length) {
  case 1:
    mainStr = result[0];
    break;

  case 2:
    mainStr = `${result[0]} and ${result[1]}`;
    break;

  case 3:
    mainStr = `${result[0]}, ${result[1]} and ${result[2]}`;
    break;

  case 4:
    mainStr = `${result[0]}, ${result[1]}, ${result[2]} and ${result[3]}`;
    break;

  case 5:
    mainStr = `${result[0]}, ${result[1]}, ${result[2]}, ${result[3]} and ${result[4]}`;
    break;
}

  return mainStr;
}
console.log(formatDuration(33243586));
