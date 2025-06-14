//courses.js
const Acourse = {
    code = "CSE121b",
    name: "JavaScript Language",
    sections:[ {
        sectionNum: 1,
        roomNum: 'STC 353',
        enrolled: 26,
        days:'TTh',
        instructor: 'BroT'
    },
    {
        sectionNum: 2,
        roomNum:'STC347',
        enrolled:28,
        days:'TTh',
        instructor: 'Sis A'}
        ],
        enrollStudent: function(sectionNum){
            const sectionIndex = this.section,findIndex(
            section => section.sectionNum == sectionNum
            );
            if (sectionIndex >=0){
                this.sections[sectionIndex].enrolled++;
                functions(this.sections);
            }
        }
        dropStudent: function(sectionNum){
        const sectionIndex = this.section.findIndex(
            (section) => section.sectionNum == sectionNum
        );
             if (sectionIndex >=0){
                 this.sections[sectionIndex].enrolled--;
                functions(this.sections);
            }
        }
            
};
document.querySelector('#enrollStudent').addEventListener('click', function() {
    const sectionNum = document.querySelector('#sectionNumber').value;
    Acourse.enrollStudent(sectionNum);
});
document.querySelector('#dropStudent').addEventListener('click', function() {
    const sectionNum = document.querySelector('#sectionNumber').value;
    Acourse.enrollStudent(sectionNum);
});
const sectionNum = document.querySelector('#sectionNumber').value;

const sectionNum = document.querySelctor.enrollStudent();

Acourse.enrollStudent(sectionNum);
document.querySelector('#courseName').textContent = Acourse.name;
document.querySelector('#courseCode').textContent = Acourse.code;