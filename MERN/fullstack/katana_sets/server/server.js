const express = require('express');
const cors = require("cors");
const port = 8000;

require("./config/mongoose.config");


const app = express();

app.use(express.json());

app.get("/", (req, res) => {
    res.json({ hello: "world" });
});

app.get("/api/katanasets", (req, res) => {
    console.log(req);

    res.json({
        sets: [
            {
                id: 1,
                name: "Yasha's Embers",
                description: "Beware the warriors fiery vengeance."
            },
            {
                id: 2,
                name: "Warrior's Brush",
                description: "Like a master caligrapher's brush stroke, written in blood."
            },
            {
                id: 3,
                name: "Mamushi Venom",
                description: "Your Blades strike home with venomous precision."
            },
            {
                id: 4,
                name: "Twilight Oni",
                description: "As night falls, death approaches."
            },
            {
                id: 5,
                name: "Fuujin's Secret",
                description: "The terrible force of an unseen tempest."
            },
            {
                id: 6,
                name: "Genbu's Darkness",
                description: "For warriors who celebrate the shadows."
            },
            {
                id: 7,
                name: "Spring Bamboo",
                description: "Even the oldest samurai fights with the vigor of youth."
            },
            {
                id: 8,
                name: "Ghost Bear's Paw",
                description: "For a samurai who is both playful and deadly."
            },
            {
                id: 9,
                name: "Dueling Festival",
                description: "Your foes with drink and feast on chaos and blood."
            },
            {
                id: 10,
                name: "Breath of Hachiman",
                description: "Let the kami of the samurai guide your blades."
            },
            {
                id: 11,
                name: "Hijiki in Sunlight",
                description: "What hidden threats lie beneath the calm, golden surface?"
            },
            {
                id: 12,
                name: "Gold Koi River",
                description: "For blades quick as the streak of a Koi in a sunlit stream."
            },
            {
                id: 13,
                name: "Bishamon's Fortune",
                description: "Destiny favors the noble-hearted warrior."
            },
            {
                id: 14,
                name: "Warrior's Faith",
                description: "Trust your weapons.  Believe in yourself."
            },
            {
                id: 15,
                name: "Hunting Bear",
                description: "Become a force of nature."
            },
            {
                id: 16,
                name: "Yuzu Peel",
                description: "Only for the most resilient and robust blades."
            },
            {
                id: 17,
                name: "Azure Dragon",
                description: "Signature of the wise warrior who fights for peace and plenty."
            },
            {
                id: 18,
                name: "Shogun's Storm",
                description: "Sweep your enemies aside with righteous fury."
            },
            {
                id: 19,
                name: "Island's Keeper",
                description: "For warriors who will sacrifice everything for their homes."
            },
            {
                id: 20,
                name: "Tanuki's Brush",
                description: "The choice for wild and unpredictable blades."
            },
            {
                id: 21,
                name: "Hidden Forest",
                description: "The bamboo stirs at the passage of a true warrior."
            },
            {
                id: 22,
                name: "Midnight Hanabi",
                description: "Pierce the darkness with glinting blades."
            },
            {
                id: 23,
                name: "Sly Tanuki",
                description: "For the samurai who knows neither friend nor foe...only destruction."
            },
        ],
    });
});

app.get("/api/katanasets/:id", (req, res) => {
    res.json({
        set: {
            id: req.params.id
        }
    });
});

app.post("/api/katanasets", (req, res) => {
    res.json({
        status: "success",
        set: req.body
    });
});

app.put("/api/katanasets/:id", (req, res) => {
    console.log(req.body);

    res.json({
        status: "success",
        msg: `Updated set id: ${req.params.id}`
    });
});

app.delete("/api/cities/:id", (req, res) => {
    console.log(req.params);

    res.json({
        status: "success",
        msg: `Deleted set id: ${req.params.id}`,
    });

});

app.listen(port, () => {
    console.log(`Listening on port ${port} for requests to respond to.`)
}); 