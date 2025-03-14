const months = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December",
  ];
  const weekdays = [
    "Sunday",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
  ];
  
  const giveaway=document.querySelector('.giveaway');
  const deadline=document.querySelector('.deadline');
  const items = document.querySelectorAll('.deadline-format h4');
//you can set a futer date
  let tempDate =new Date();
  let tempYear = tempDate.getFullYear();
  let tempMonth = tempDate.getMonth();
  let tempDay = tempDate.getDate();

  //let futereDate = new Date(2021,4,24,11,30,0);
  const futereDate = new Date(tempYear,tempMonth,tempDay + 10,11,30,0);
  const year = futereDate.getFullYear();
  const hours = futereDate.getHours();
  const minutes = futereDate.getMinutes();

  let month = futereDate.getMonth();
  month = months[month];
  const date = futereDate.getDate();
  const weekends = weekdays[futereDate.getDay()];
  giveaway.textContent = `giveaway ends on ${weekends} ${date} ${month} ${year} ${hours} ${minutes}`;

  const futureTime = futereDate.getTime();

  function getRemainingTime(){
      const today = new Date().getTime();
      const t = futureTime - today;
      //1s = 1000ms
      //1m = 60s
      //1hr = 60min
      //1day = 24hr

      const oneDay = 24*60*60*1000;
      const oneHour = 60*60*1000;
      const oneMinute = 60*1000;

      let days =t/oneDay;
      days = Math.floor(days);
      let hours = Math.floor((t % oneDay) / oneHour);
      let minutes = Math.floor((t % oneHour) / oneMinute);
      let seconds = Math.floor((t % oneMinute) / 1000);
        
    
      function format(item){
          if(item < 10){
              return item = `0${item}`;
          }else{
              return item;
          }
      }

      const values = [days,hours,minutes,seconds];
      items.forEach(function(item,index){
          item.innerHTML = format(values[index]);
      })
      if(t<0){
          clearInterval(countdown);
          deadline.innerHTML = `<h4 class='expired'>sorry, this giveaway has exparied</h4>`;
      }
  }
  let countdown = setInterval(getRemainingTime,1000);

  getRemainingTime();