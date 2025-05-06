// Bar Chart
const barCtx = document.getElementById('barChart').getContext('2d');
new Chart(barCtx, {
    type: 'bar',
    data: {
        labels: ['Vegetarian', 'Gluten-Free', 'Omnivore', 'Vegan'],
        datasets: [{
            label: 'Diet Type Count',
            data: [10, 20, 15, 5],
            backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#AA66CC']
        }]
    }
});

// Digestive Issues Frequency (Pie Chart)
const pieCtx = document.getElementById('pieChart').getContext('2d');
new Chart(pieCtx, {
    type: 'pie',
    data: {
        labels: ['Never', 'Sometimes', 'Often'],
        datasets: [{
            data: [12, 25, 8],
            backgroundColor: ['#FF9999', '#99FF99', '#9999FF']
        }]
    }
});

// Avg Stress by Age Group (Line Chart)
const lineCtx = document.getElementById('lineChart').getContext('2d');
new Chart(lineCtx, {
    type: 'line',
    data: {
        labels: ['20-29', '30-39', '40-49', '50-59', '60+'],
        datasets: [{
            label: 'Avg Stress Level',
            data: [5.5, 6.3, 4.9, 3.2, 7.1],
            borderColor: '#FF6384',
            fill: false
        }]
    }
});

// Doughnut Chart (Nutrient Distribution)
const doughnutCtx = document.getElementById('doughnutChart').getContext('2d');
new Chart(doughnutCtx, {
    type: 'doughnut',
    data: {
        labels: ['Protein', 'Carbs', 'Fat', 'Fiber'],
        datasets: [{
            label: 'Nutrient Distribution',
            data: [30, 40, 15, 15],
            backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#AA66CC']
        }]
    }
});
