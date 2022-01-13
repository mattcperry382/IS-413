$('#calculate').click((event) => {
    assignments = $('#assignments').val() * 55 / 100;
    groupProject = $('#group-project').val() * 5 / 100;
    quizzes = $('#quizzes').val() * 10 / 100;
    exams = $('#exams').val() * 20 / 100;
    intex = $('#intex').val() * 10 / 100;
    finalGrade = assignments + groupProject + quizzes + exams + intex;

    if (finalGrade >= 94) letterGrade = 'A'
    else if (finalGrade >= 90) letterGrade = 'A-'
    else if (finalGrade >= 87) letterGrade = 'B+'
    else if (finalGrade >= 84) letterGrade = 'B'
    else if (finalGrade >= 80) letterGrade = 'B-'
    else if (finalGrade >= 77) letterGrade = 'C+'
    else if (finalGrade >= 74) letterGrade = 'C'
    else if (finalGrade >= 70) letterGrade = 'C-'
    else if (finalGrade >= 67) letterGrade = 'D+'
    else if (finalGrade >= 64) letterGrade = 'D'
    else if (finalGrade >= 60) letterGrade = 'D-'
    else letterGrade = 'E';

    alert(`Your final grade in IS 413 will be ${letterGrade} at ${finalGrade}%.`);
})