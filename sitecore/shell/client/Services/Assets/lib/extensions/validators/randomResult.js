EntityService.utils.validator.add("randomResult", function (value, params) {
    var result = false;

    var getRandomInt = function (min, max)
    {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    var number = getRandomInt(0, 1);
    result = number == 1;

    return result;
});