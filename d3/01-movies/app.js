const parseDate = s => d3.timeParse('%Y-%m-%d')(s);
const type = (d) => { 
    return  { steps: +d.Steps, date: parseDate(d.Date) } 
};

d3.csv('data/week51.csv', type).
    then(res => console.log('csv:', res));
