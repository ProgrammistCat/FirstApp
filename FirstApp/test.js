


function func() {} // undefined

class Player {
    method() {}
}


console.log(typeof func())




function a(aValue, bValue) {
    return aValue > bValue
}

function b() {
    let aValue = 1
    let bValue = 1
    
    a(aValue, bValue)
}