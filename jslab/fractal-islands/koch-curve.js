(() => {
    const canvas = document.createElement('canvas')
    document.body.appendChild(canvas)

    const context = canvas.getContext('2d')
    const width = canvas.width = 420
    const height = canvas.height = 420

    // The starting cordinates, basically tiltiing the Koch 
    // shape so that when we add three together they form the snowflake
    const startingPoints = {
        p1: {
            x: 0,
            y: -150
        },
        p2: {
            x: 150,
            y: 100
        },
        p3: {
            x: -150,
            y: 100
        }
    }

    // Draw relative to center of the screen
    context.translate(.5 * width, .5 * height)

    // add a default limit of three as we don't want an infinite loop
    const koch = (a, b, limit = 3) => {
        let [dx, dy] = [b.x - a.x, b.y - a.y]
        let dist = Math.sqrt(dx * dx + dy * dy)
        let unit = dist / 3
        let angle = Math.atan2(dy, dx)

        //This will be the triangular shape that makes the 'points' on the snowflake
        let p1 = {
            x: a.x + dx / 3,
            y: a.y + dy / 3
        }
        let p3 = {
            x: b.x - dx / 3,
            y: b.y - dy / 3
        }
        let p2 = {
            x: p1.x + Math.cos(angle - Math.PI / 3) * unit,
            y: p1.y + Math.sin(angle - Math.PI / 3) * unit
        }

        if (limit > 0) {
        	// Decrease limit each time it's called
            koch(a, p1, limit - 1)
            koch(p1, p2, limit - 1)
            koch(p2, p3, limit - 1)
            koch(p3, b, limit - 1)
        } else {
            context.beginPath()
            context.moveTo(a.x, a.y)
            context.lineTo(p1.x, p1.y)
            context.lineTo(p2.x, p2.y)
            context.lineTo(p3.x, p3.y)
            context.lineTo(b.x, b.y)
            context.stroke()
        }
    }

    // draw the shape using our predefined co-ordinates
    koch(startingPoints.p1, startingPoints.p2)
    koch(startingPoints.p2, startingPoints.p3)
    koch(startingPoints.p3, startingPoints.p1)

})()
