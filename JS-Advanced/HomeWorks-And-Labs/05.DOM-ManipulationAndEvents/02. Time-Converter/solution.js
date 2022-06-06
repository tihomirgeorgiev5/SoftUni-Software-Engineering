function attachEventsListeners() {

    const days = document.getElementById('days');
    const hours = document.getElementById('hours');
    const minutes = document.getElementById('minutes');
    const seconds = document.getElementById('seconds');

    const commons = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400, 
    };

    document.getElementById('daysBtn').addEventListener('click',onConvert);
    document.getElementById('hoursBtn').addEventListener('click',onConvert);
    document.getElementById('minutesBtn').addEventListener('click',onConvert);
    document.getElementById('secondsBtn').addEventListener('click',onConvert);

    function convert(value, unit) {

        const days = value / commons[unit];
        return  {
            days,
            hours: days*commons.hours,
            minutes:  days*commons.minutes,
            seconds:  days*commons.seconds,
        };
    }

    function onConvert(event) {
        const input = event.target.parentElement.querySelector('input[type="text"]');

        const time = convert(Number(input.value), input.id);
      
        
        days.value = time.days;
        hours.value = time.hours;
        minutes.value = time.minutes;
        seconds.value = time.seconds;
        
    }
}