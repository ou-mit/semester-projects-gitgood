let alarmSound = document.getElementById("alarmSound");

function startTimer() {
    const hours = parseInt(document.getElementById('hours').value, 10) || 0;
    const minutes = parseInt(document.getElementById('minutes').value, 10) || 0;
    const seconds = parseInt(document.getElementById('seconds').value, 10) || 0;
  
    const totalSeconds = hours * 3600 + minutes * 60 + seconds;
  
    let timer = totalSeconds;
    const timerDisplay = document.getElementById('timerDisplay');
  
    const countdown = setInterval(() => {
      const hoursLeft = Math.floor(timer / 3600);
      const minutesLeft = Math.floor((timer % 3600) / 60);
      const secondsLeft = timer % 60;
  
      timerDisplay.innerHTML = `${formatTime(hoursLeft)}:${formatTime(minutesLeft)}:${formatTime(secondsLeft)}`;
  
      if (timer <= 0) {
        clearInterval(countdown);
        timerDisplay.innerHTML = 'Countdown Complete!';
        playAlarmSound();
      } else {
        timer--;
      }
    }, 1000);
  }
  
  function formatTime(time) {
    return time < 10 ? `0${time}` : time;
  }

  function playAlarmSound() {
    alarmSound.play();
  }
  
