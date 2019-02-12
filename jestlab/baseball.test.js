const baseball = require('./baseball');

test('reads stats that are already present', () => {
  const player = {
    BA: 0.3
  };

  expect(baseball.statisticFinder.getStatistic('BA', player)).toBe(0.3);

});
