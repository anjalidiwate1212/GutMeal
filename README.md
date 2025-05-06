**GutMeal**

  GutMeal is a personalized meal recommendation platform that helps users discover gut-friendly and goal-oriented meal plans based on their dietary preferences and nutritional needs. 
  By allowing users to input up to three food items, the system fetches real-time nutritional data via the Open Food Facts API and visualizes it using interactive charts. 
  The core focus is to recommend scientifically backed meal plans—such as keto, low-FODMAP, or high-fiber diets—that align with users’ health goals like improved digestion, metabolic balance, or reduced inflammation.



**API Endpoints Used**
**The project utilizes the following external APIs:**

  Open Food Facts API
  
  https://world.openfoodfacts.org/cgi/search.pl
  Used to fetch nutrition data (calories, fat, carbs, protein, fiber) based on user-inputted food names.
  
  Example call:
  https://world.openfoodfacts.org/cgi/search.pl?search_terms=banana&search_simple=1&action=process&json=1



**Data Model (ERD Diagram)**

  The core Entity Relationship Diagram (ERD) includes:
  
  User: Stores personal information (name, preferences, restrictions)
  
  MealPlan: Represents curated meal plans (e.g., Keto, Low-FODMAP)
  
  FoodItem: Individual food components with nutrition metadata
  
  TrackingEntry: Stores nutrient breakdown based on user input
  
  Recommendation: Connects User → MealPlan based on logic 

![image](https://github.com/user-attachments/assets/8d065efd-1c09-4cde-8be9-9c3ad14809dc)



**Notable Technical Challenges & Solutions**

  **Challenges**
  
  **Slow API response / timeouts**- Added loading spinner and a fetch timeout using AbortController in JavaScript
  
  **Multiple food input support**- Designed support for 3 separate input blocks to aggregate macros
  
  **Chart rendering glitches Properly**- destroyed and re-rendered all Chart.js instances on every update
  
  **Routing issues**- Fixed broken links by aligning route URLs with correct controller action (/Home/Charts)
  
  **MVC Architecture**- Had difficulties coverting to MVC architecture
  


**CRUD Implementation Overview**
  **Basic Create, Read, Update, Delete (CRUD) functionality was implemented as follows:**

  Entity	  Functionality
  
  MealPlan	User can add(using form), edit, delete meal plans
  
  FoodItem	Linked to API, user can input meals and food name for marconutrients output
  
  Tracking	Users can submit food + quantity , view charts 
  
  UserPrefs	Preferences can be saved/updated per user
  
  Front-end: Razor Views and HTML forms
  
  Back-end: C# MVC Controllers
  
  Storage: In-memory Singleton



    
  










