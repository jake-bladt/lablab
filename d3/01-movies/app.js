const parseDate = s => d3.timeParse('%Y-%m-%d')(s);
const getTranche = i => Math.min(10000,  parseInt(i / 1000) * 1000);

const type = (d) => { 
    return  { 
        steps: +d.Steps,
        tranche: getTranche(+d.Steps),
        date: parseDate(d.Date) 
    } 
};

d3.csv('data/week51.csv', type).
    then(res => console.log('csv:', res));
