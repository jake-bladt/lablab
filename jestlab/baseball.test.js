const baseball = require('./baseball');

const batter = {
    BA: 0.3,
    HR: 19
  };

test('reads stats that are already present', () => {
  expect(baseball.statisticFinder.getStatistic('BA', batter)).toBeCloseTo(0.3);
  expect(baseball.statisticFinder.getStatistic('HR', batter)).toBe(19);
});

test('throws an error when stats are not present', () => {
  expect(() => baseball.statisticFinder.getStatistic('ERA', batter)).toThrow('Statistic calculator not implemented.');
});
