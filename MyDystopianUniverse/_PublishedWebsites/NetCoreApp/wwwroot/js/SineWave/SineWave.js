var SineWaves = [];

SineWaves.push({ Id: 'sinewave-svg-1-path', Amplitude: 20, Comprimento: 15, Frequencia: 1.2, T: 0 });
SineWaves.push({ Id: 'sinewave-svg-2-path', Amplitude: 10, Comprimento: 20, Frequencia: 3, T: 0 });
SineWaves.push({ Id: 'sinewave-svg-3-path', Amplitude: 16, Comprimento: 20, Frequencia: -1.3, T: 0 });

let xs = [];
for (var i = 0; i <= 500; i++) {
    xs.push(i);
}

let t = 0;

function animate() {
    for (var i in SineWaves) {
        let points = xs.map(x => {

            let y = 200 + SineWaves[i].Amplitude * Math.sin((x + SineWaves[i].T) / SineWaves[i].Comprimento);

            return [x, y];
        });

        let path = "M" + points.map(p => {
            return p[0] + "," + p[1];
        }).join(" L");

        document.getElementById(SineWaves[i].Id).setAttribute("d", path);

        SineWaves[i].T += SineWaves[i].Frequencia;
    }

        requestAnimationFrame(animate);
}

animate();


