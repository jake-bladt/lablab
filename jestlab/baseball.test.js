const baseball = require('./baseball');

test('reads stats that are already present', () => {
  const player = {
    BA: 0.3,
    HR: 19
  };

  expect(baseball.statisticFinder.getStatistic('BA', player)).toBeCloseTo(0.3);
  expect(baseball.statisticFinder.getStatistic('HR', player)).toBe(19);

});
