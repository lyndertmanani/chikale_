using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Green_house_chikale.System_properties
{
    public partial class Soil : UserControl
    {
        // State variables to track soilType, cropRecommendation, and searchPerformed
        private string soilType = "Oops!";
        private string cropRecommendation = "No recommendation for unknown soil types ";
        private bool searchPerformed = false;

        // Predefined descriptions for each soil type
        private readonly Dictionary<string, string> soilDescriptions = new Dictionary<string, string>
        {
            { "Clay Soil", "Sticky, dense, heavy, compact, water-retentive, nutrient-rich, fertile, organic matter, drainage, root development, aeration, cloddiness, moisture levels, potatoes, beans, cabbages, raised beds, mulching, hold more water, hard when dry, dark in color, small particle texture" },
            { "Sandy Soil", "Coarse, loose, light, low-nutrient, fast-draining, water-permeable, drought-prone, well-drained, carrots, radishes, lettuce, fertilization, compost, mulching, drip irrigation, hold less water, soft when dry, light in color, large particle texture" },
            { "Silt Soil", "Fine, silky, smooth, moderate fertility, moisture-retentive, easily compacted, treading, garden machinery, peas, spinach, broccoli, compaction prevention, no-till practices, hold more water, slightly hard when dry, moderate in color, medium particle texture" },
            { "Loam Soil", "Balanced, optimal, versatile, drainage, moisture retention, fertility, well-aerated, tomatoes, peppers, pumpkins, organic matter, cover cropping, erosion control, weed suppression, hold more water, crumbly when dry, moderate to dark in color, mixture of small, medium, and large particle sizes" },
            { "Chalky Soil", "Alkaline, limestone, ericaceous plants, acidic amendments, lavender, rosemary, thyme, drainage, nutrient deficiency, pH levels, organic matter, ground cover plants, hold less water, powdery when dry, light in color, medium particle texture" },
            // Add more soil types and descriptions here
        };


        public Soil()
        {
            InitializeComponent();
            Soil_title.Visible = false;
            soilData.Visible = false;
            Errorx.Visible = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            
            string userInput = SearchBox.Text.ToLower();

            if (SearchBox.Text == "")
            {
                Errorx.Visible =true;
                Soil_title.Visible = false;
                soilData.Visible = false;
                Errorx.Text = "Please provide neccessay data, Search box is empty";
            }
            else
            {
                Soil_title.Visible = true;
                soilData.Visible = true;
                // Check if search box input is too long
                if (userInput.Length > 100)
                {
                    Errorx.Visible = true;
                    Soil_title.Visible = false;
                    soilData.Visible = false;
                    Errorx.Text = "Text too long for soil description";
                    soilData.Text = "";
                    return;
                }

                // Function to calculate similarity between user input and soil descriptions
                double CalculateSimilarity(string str1, string str2)
                {
                    var words1 = new HashSet<string>(str1.Split(' '));
                    var words2 = new HashSet<string>(str2.Split(' '));

                    var intersection = new HashSet<string>(words1);
                    intersection.IntersectWith(words2);

                    var union = new HashSet<string>(words1);
                    union.UnionWith(words2);

                    return (double)intersection.Count / union.Count;
                }

                // Calculate similarity for each soil type and choose the one with the highest similarity
                double maxSimilarity = 0;
                string bestMatch = "unknown";

                foreach (var type in soilDescriptions.Keys)
                {
                    var description = soilDescriptions[type].ToLower();
                    var similarity = CalculateSimilarity(userInput, description);

                    if (similarity > maxSimilarity)
                    {
                        maxSimilarity = similarity;
                        bestMatch = type;
                    }
                }

                // Set the identified soil type and crop recommendation
                soilType = bestMatch;
                cropRecommendation = $"{bestMatch}: {GetRecommendationForSoilType(bestMatch)}";

                // Set the searchPerformed state to true
                searchPerformed = true;

                // Update UI
                Soil_title.Text = soilType;
                soilData.Text = cropRecommendation;
            }
        }

        // Function to get crop recommendation based on soil type
        private string GetRecommendationForSoilType(string type)
        {
            switch (type)
            {
                case "Clay Soil":
                    return "is characterized by its fine particles that compact easily, leading to potential drainage issues. This soil type tends to retain water, making it beneficial for plants that enjoy consistent moisture levels. However, the compact nature of clay can hinder root development and nutrient absorption. To improve fertility, incorporate organic matter like compost or well-rotted manure. This not only enhances nutrient content but also helps break up clods, promoting better aeration and water movement. Ideal crops for clay soil include Potatoes, Beans, and Cabbages, which thrive in the nutrient-rich environment. However, be mindful of waterlogged conditions, and consider raised beds to improve drainage and prevent root rot. Additionally, mulching can help regulate soil temperature and reduce moisture loss.";

                case "Sandy Soil":
                    return "with its coarse and loose texture, provides excellent drainage but lacks nutrient retention. This soil type allows water to pass through quickly, making it suitable for plants that prefer drier conditions. Carrots, Radishes, and Lettuce are well-suited for sandy soil, as they thrive in well-drained environments. However, the low nutrient content in sandy soil requires regular fertilization to ensure healthy plant growth. To enhance water retention, incorporate organic matter such as compost or leaf mulch. Consider using a layer of mulch to reduce water evaporation and maintain moisture levels for optimal plant growth. Amending sandy soil with organic materials not only improves its overall structure but also creates a more favorable environment for a variety of crops. Additionally, drip irrigation systems can efficiently deliver water to the root zone, minimizing water wastage and promoting plant health.";

                case "Silt Soil":
                    return "composed of fine particles, offers good fertility but is prone to compaction. This soil type has a smooth, silky texture and retains moisture well. Peas, Spinach, and Broccoli thrive in the nutrient-rich conditions of silt soil. However, its fine particles can easily compact, reducing aeration and impeding root development. To prevent compaction, add organic matter regularly, promoting better aeration and root development. Implementing no-till practices can further preserve soil structure and enhance its overall health. Be cautious with excessive foot traffic or heavy machinery that can lead to compaction. With proper care, silt soil can provide an excellent foundation for a diverse range of crops, offering a balance between drainage and water retention.";

                case "Loam Soil":
                    return "often considered the gardener’s dream, features a balanced mix of sand, silt, and clay particles. This versatile soil type provides optimal drainage, moisture retention, and fertility, making it suitable for a wide range of plants. Tomatoes, Peppers, and Pumpkins thrive in the well-aerated and nutrient-rich environment of loam soil. The combination of good drainage and fertility reduces the need for extensive amendments. Maintaining this balance is key, achieved by regularly incorporating organic matter such as compost or well-rotted manure. This not only enhances nutrient content but also promotes a healthy soil structure. Additionally, cover cropping can help reduce erosion, improve soil fertility, and suppress weeds, contributing to the overall health of loam soil.";

                case "Chalky Soil":
                    return "characterized by its alkaline nature due to the presence of limestone, requires careful consideration for plant selection. Lavender, Rosemary, and Thyme are well-suited for this soil type, thriving in alkaline conditions. To accommodate other plants, adjust the soil’s pH by adding acidic amendments. Chalky soil tends to drain well, but it may lack certain nutrients. Incorporating organic matter such as well-rotted manure or compost helps improve fertility and structure. Gardeners should monitor pH levels regularly and choose plants accordingly, ensuring they thrive in the alkaline conditions of chalky soil. Additionally, using ground cover plants can help reduce erosion and maintain soil structure, contributing to the overall health of chalky soil.";

                default:
                    return "No recommendation";
            }
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            Errorx.Visible = false;
        }
    }
}
