
 
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
    if (this.goals.hasOwnProperty(peak)) {
      if (this.resources === 0) {
        throw new Error('You don\'t have enough resources to start the hike');
      }
      const difference = this.resources - time * 10;
      if (difference < 0) {
        return 'You don\'t have enough resources to complete the hike';
      }
      this.resources -= time * 10;
      this.listOfHikes.push({ peak, time, difficultyLevel });
      return `You hiked ${peak} peak for ${time} hours and you have ${this.resources}% resources left`;
    } else {
      throw new Error(`${peak} is not in your current goals`);
    }
  }
  rest(time) {
    const additionalResources = time * 10;
    if (this.resources + additionalResources >= 100) {
      this.resources = 100;
      return 'Your resources are fully recharged. Time for hiking!';
    }
    this.resources += additionalResources;
    return `You have rested for ${time} hours and gained ${additionalResources}% resources`;
  }
  showRecord(criteria) {
    if (this.listOfHikes.length === 0) {
      return `${this.username} has not done any hiking yet`;
    }
    if (criteria === 'hard' || criteria === 'easy') {
      const existingHikes = this.listOfHikes.filter((h) => h.difficultyLevel === criteria);
      if (existingHikes.length === 0) {
        return `${this.username} has not done any ${criteria} hiking yet`;
      }
      const hike = existingHikes.sort((a, b) => a.time - b.time)[0];
      return `${this.username}'s best ${criteria} hike is ${hike.peak} peak, for ${hike.time} hours`;
    }
    return `All hiking records:\n${this.listOfHikes
      .map((h) => `${this.username} hiked ${h.peak} for ${h.time} hours`)
      .join('\n')}`;
  }
}
 