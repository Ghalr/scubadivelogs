angular.module('AngularDemo.SideMenuController', [])
    .controller('SideMenuCtrl', function ($scope) {
        
        // Define the content of the side bar menu
        $scope.MenuContent = [{
            title: {text: "Hi Corentin", link:"#/"},
            subitems: [{ text: "My Account", link: "#/" }, { text: "Logout", link: "#/" }],
            expanded: false
        },
        {
            title: { text: "Logbook", link: "#/" },
            subitems: [{ text: "My Logs", link: "#/" },
                        { text: "Add New", link: "#/" },
                        { text: "Statistics", link: "#/" }],
            expanded: false
        },
        {
            title: { text: "Help", link: "#/" },
            subitems: [{ text: "FAQ", link: "#/" },
                        { text: "Support", link: "#/" }],
            expanded: false
        }
        ];

        // Determines whether the class should be active or not
        // and returns the necessary string
        $scope.activeClassString = function (menuItem) {
            if (menuItem.expanded) return "active";
            else return "";
        };

    });