# CSC 592 Assignment 2 – VR Space Museum

## Project Overview

The **VR Space Museum** is an educational virtual reality museum developed in **Unity** for **CSC 592 Assignment 2**.

The goal of this project is to create an immersive museum environment where users can navigate through a virtual space and learn about different objects in the Solar System.

The museum contains five main exhibits:

- Sun
- Earth
- Moon
- Mars
- Saturn

Each exhibit is displayed on an individual pedestal and contains an educational information panel. The information panel automatically appears when the user approaches an exhibit and disappears when the user moves away.

The project uses the **Unity XR Interaction Toolkit** for XR functionality and the **XR Device Simulator** for development and testing.

---

## Museum Topic – The Solar System

The educational topic selected for this museum is the **Solar System**.

I selected this topic because space and planetary science can be presented effectively in a three-dimensional virtual environment. A VR museum allows the user to move through the environment, observe representations of astronomical objects, and receive educational information through interactive exhibits.

The exhibits are arranged with enough open space between them to allow comfortable navigation through the museum.

---

## Museum Environment

The museum was designed as an enclosed virtual exhibition space.

The environment includes:

- Floor
- Ceiling
- Front wall
- Back wall
- Left wall
- Right wall
- Museum lighting
- Individual exhibit pedestals
- Open walking areas between exhibits
- Educational information panels

The exhibits are positioned throughout the museum to provide enough walking space while reducing overlap between their proximity-trigger areas.

---

# Exhibitions

## 1. Sun

The Sun exhibit represents the star at the center of the Solar System.

When the user approaches the Sun, an educational information panel automatically appears. The Sun also includes continuous rotation animation to make the exhibit more visually dynamic.

---

## 2. Earth

The Earth exhibit represents our home planet.

The model uses blue and green surface elements to visually represent Earth's oceans and land areas.

When the user approaches Earth, its educational information panel appears automatically.

Earth also includes continuous rotation animation.

---

## 3. Moon

The Moon exhibit represents Earth's natural satellite.

It is positioned near the Earth exhibit while maintaining enough space for the user to navigate between the exhibits.

Approaching the Moon activates its own educational information panel containing information about the Moon.

---

## 4. Mars

Mars is represented using a reddish surface color to visually represent the Red Planet.

When the user approaches Mars, a proximity trigger activates the Mars information panel. The panel disappears when the user leaves the exhibit area.

---

## 5. Saturn

The Saturn exhibit includes both the planet and its recognizable ring system.

The educational information panel contains information about Saturn and its rings. The panel appears when the user approaches the exhibit and disappears when the user moves away.

---

# VR/XR Navigation

The project uses the **Unity XR Interaction Toolkit** to provide XR navigation and interaction functionality.

The XR setup includes:

- XR Origin (XR Rig)
- XR Interaction Manager
- Left Controller
- Right Controller
- XR locomotion components
- XR Device Simulator

The **XR Device Simulator** was used during development to navigate and test the museum without requiring a physical VR headset for every development test.

The simulator allows the user to move around the museum and approach each exhibit to test its interactive features.

---

# Proximity-Based Interaction System

Each museum exhibit contains a proximity-based interaction.

A collider configured as a trigger is attached to each exhibit. When the player enters the trigger area, the corresponding educational information panel becomes visible.

When the player exits the trigger area, the information panel disappears.

This functionality is controlled using a custom C# script:

`ProximityInfo.cs`

The interaction system was also designed to prevent multiple information panels from remaining visible simultaneously. When the user approaches another exhibit, the previous information panel is hidden.

This provides a cleaner museum experience and prevents information from different exhibits from overlapping on the screen.

---

# Exhibit Animation

A custom C# script is used to create continuous rotation animations for multiple exhibits:

`PlanetRotation.cs`

The rotation animation adds movement to the museum exhibits and makes the environment feel more dynamic.

Multiple astronomical objects in the museum use this animation system.

---

# Graduate Bonus Completed

## Bonus 2 – Animation on Exhibitions

For the graduate-level bonus requirement, I implemented **animation on multiple museum exhibitions**.

The planetary objects continuously rotate while the museum is running using the custom `PlanetRotation.cs` script.

This provides visible animation on at least two exhibitions and adds additional visual movement to the museum experience.

---

# Technologies Used

The project was developed using:

- Unity Unity 6.3 LTS (6000.3.22f1)
- Unity XR Interaction Toolkit
- XR Device Simulator
- C#
- TextMeshPro
- Unity UI
- Unity Colliders and Trigger Events
- Git
- GitHub
- GitHub Desktop

---

# Project Structure

The main Unity project files are organized as follows:

```text
CSC592-Assignment2-VRMuseum/
│
├── Assets/
│   ├── Materials/
│   ├── Samples/
│   ├── Scenes/
│   ├── Scripts/
│   ├── Settings/
│   ├── TextMesh Pro/
│   └── XRI/
│
├── Packages/
│
├── ProjectSettings/
│
├── Screenshots/
│   ├── MuseumOverview.png
│   ├── Sun.png
│   ├── Earth.png
│   ├── Moon.png
│   ├── Mars.png
│   └── Saturn.png
│
├── DemoVideo/
│   └── SpaceMuseumDemo.mp4
│
└── README.md
```

Generated Unity folders such as `Library`, `Temp`, and `Logs` are excluded from the GitHub repository using the Unity `.gitignore`.

---

# Screenshots

The following screenshots demonstrate the completed museum environment and the interactive educational exhibits.

## Museum Overview

The museum overview shows the enclosed museum environment, lighting, exhibit pedestals, and the overall arrangement of the astronomical exhibits.

![Museum Overview](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/MuseumOverview.png)

---

## Sun Exhibit

The Sun exhibit includes a proximity-based educational information panel and rotation animation.

![Sun Exhibit](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/Sun.png)

---

## Earth Exhibit

The Earth exhibit displays educational information when the user approaches the planet.

![Earth Exhibit](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/Earth.png)

---

## Moon Exhibit

The Moon exhibit contains its own proximity-triggered educational information panel.

![Moon Exhibit](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/Moon.png)

---

## Mars Exhibit

The Mars information panel automatically appears when the user enters the exhibit's proximity area.

![Mars Exhibit](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/Mars.png)

---

## Saturn Exhibit

The Saturn exhibit includes the planet's ring system and an educational information panel containing information about Saturn and its rings.

![Saturn Exhibit](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/Saturn.png)

---

# Demo Video

The screen recording demonstrates the completed VR Space Museum in operation.
![Saturn Exhibit](https://github.com/overootheroot/CSC592-Assignment2-VRMuseum/blob/main/Screenshots%20/Saturn.png)

The demonstration includes:

- Navigation through the museum
- Visiting the different astronomical exhibits
- Proximity-based information panels
- Information panels appearing and disappearing
- Movement between exhibits
- Animated rotating exhibits
- Museum lighting and environment
- XR Device Simulator navigation

### ▶️ Watch the VR Space Museum Demo

[**Click here to watch the Space Museum Demo**](DemoVideo/SpaceMuseumDemo.mp4)

---

# How to Open the Project

To open and run the project:

1. Clone or download this GitHub repository.
2. Open **Unity Hub**.
3. Select **Add Project from Disk**.
4. Select the downloaded `CSC592-Assignment2-VRMuseum` folder.
5. Open the project using the appropriate Unity 6 version.
6. Open the museum scene from the `Assets/Scenes` folder.
7. Press **Play** to run the museum.

The XR Device Simulator can be used to navigate through the museum during testing.

---

# Project Testing

The completed museum was tested to verify that:

- The player can navigate through the museum.
- All five exhibits are visible and accessible.
- The museum contains a floor, walls, and ceiling.
- Each exhibit has its own educational information panel.
- Information panels appear when approaching an exhibit.
- Information panels disappear after leaving an exhibit.
- Information panels do not remain overlapping when moving between exhibits.
- Multiple exhibits contain rotation animations.
- The XR Device Simulator can be used to navigate through the environment.
- The museum provides sufficient walking space between exhibits.

---

# Assignment Information

**Course:** CSC 592  
**Assignment:** Assignment 2 – VR Museum  
**Project:** VR Space Museum  
**Development Platform:** Unity 6  
**XR Framework:** Unity XR Interaction Toolkit  
**Bonus Completed:** Bonus 2 – Animation on Exhibitions
