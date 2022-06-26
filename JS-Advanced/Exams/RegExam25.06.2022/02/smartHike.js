class SmartHike {
    constructor(username) {
        this.username = username;
        this.goals = {};
        this.listOfHikes = [];
        this.resources = 100;
    }

    addGoal(peak, altitude) {

        if (this.goals.hasOwnProperty(peak)) {
            return `${peak} has already been added to your goals`;

        } else {
            this.goals[peak] = altitude;
            return `You have successfully added a new goal - ${peak}`;
        }

    }

    hike(peak, time, difficultyLevel) {
        let diffResourTime = this.resources - time * 10
        if (this.goals.hasOwnProperty(peak) && this.resources == 0) {
            throw new Error("You don't have enough resources to start the hike")

        } else if (this.goals.hasOwnProperty(peak)) {
            if (diffResourTime < 0) {
                return "You don't have enough resources to complete the hike"
            } else {
                this.resources = diffResourTime;
                this.listOfHikes.push({
                    peak,
                    time,
                    difficultyLevel
                });
                return `You hiked ${peak} peak for ${time} hours and you have ${this.resources}% resources left`;

            }

        } else {

            throw new Error(`${peak} is not in your current goals`);

        }
    }

    rest(time) {
        this.resources += time * 10;

        if (this.resources >= 100) {
            this.resources = 100;
            return `Your resources are fully recharged. Time for hiking!`

        } else {
            return `You have rested for ${time} hours and gained ${time * 10}% resources`;

        }
    }

    showRecord(criteria) {
        let bestHikersList = this.listOfHikes.map(h => h.time);
        if (this.listOfHikes.length = 0) {
            return `${this.username} has not done any hiking yet`

        }
        if (criteria == 'hard' || criteria == 'easy') {
            for (let i = 0; i < this.listOfHikes.length; i++) {
                //this.listOfHikes[i].time < 

            }
        } else if (criteria == 'all') {
            return `All hiking records:`;
            //this.listOfHikes.forEach(h => `${h.username} hiked ${h.peak} for ${h.time} hours`)
        }
    }







}

const user = new SmartHike('Vili');
console.log(user.addGoal('Musala', 2925));
console.log(user.hike('Musala', 8, 'hard'));
console.log(user.rest(4));
console.log(user.rest(5));

