const statisticFinder = {
  getStatistic: (name, player) => {
      if(player[name]) {
        return player[name];
      } else {
        throw 'Statistic calculator not implemented.';
      }
  }
};
