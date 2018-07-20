'use strict'

const move = (beginTower, endTower) => {
  console.log(`From ${beginTower} to ${endTower}`);
}

const moveTower = (disksAmount, beginTower, endTower, tempTower) => {
  if (disksAmount == 0) return ;
  moveTower(disksAmount - 1, beginTower, tempTower, endTower);
  move(beginTower, endTower);
  moveTower(disksAmount - 1, tempTower, endTower, beginTower);
}

moveTower(4,'A','B','C');
